using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ReleaseAssistant
{
    public class Configuration
    {
        private Dictionary<string, Action<string[]>> registerMap;
        private List<Argument> arguments;

        public void Register(string argumentName, Action<string[]> doWhat)
        {
            registerMap.Add(argumentName, doWhat);
        }

        protected void WarningOptionIncorrect(string configName)
        {
            Debug.WriteLine(string.Format("Config {0} option is incorrect", configName));
        }

        protected void WarningOptionEmpty(string configName)
        {
            Debug.WriteLine(string.Format("Config {0} do not contain any options", configName));
        }

        private void RegisterBuiltInHandlers()
        {
            registerMap = new Dictionary<string, Action<string[]>>();
        }

        public void RunConfig()
        {
            foreach (var argument in arguments)
            {
                var keys = registerMap.Keys;
                foreach (var key in keys)
                {
                    if (key == argument.Name)
                    {
                        var options = argument.Options;
                        var action = registerMap[key];
                        action.Invoke(options);
                    }
                }
            }
        }

        public Configuration(string[] rawArguments)
        {
            ParseArguments(rawArguments);
            RegisterBuiltInHandlers();
        }

        private void ParseArguments(string[] rawArguments)
        {
            this.arguments = new List<Argument>();
            ArgumentFactory argumentFactory = new ArgumentFactory(rawArguments);
            Argument argument = null;
            while ((argument = argumentFactory.Next()) != null)
            {
                this.arguments.Add(argument);
            }
        }
        
        internal class Argument
        {
            public string Name { get; set; }
            public string[] Options { get; set; }

            public override string ToString()
            {
                string optionsString = "";
                if (Options != null && Options.Length > 0)
                {
                    StringBuilder builder = new StringBuilder();
                    foreach (var option in Options)
                    {
                        builder.Append(option + " ");
                    }
                    optionsString = builder.ToString();
                }
                return Name + " " + optionsString.TrimEnd();
            }
        }

        internal class ArgumentFactory
        {
            private string[] rawArguments;
            private int currentIndex = 0;

            private bool IsArgument(string st)
            {
                return st != null && st.StartsWith("-");
            }

            private string GetArgumentName(string argument)
            {
                return argument.Substring(1);
            }

            private string NextToken()
            {
                return rawArguments[currentIndex++];
            }

            private bool HasToken()
            {
                return currentIndex < rawArguments.Length;
            }

            private void ComeBack()
            {
                currentIndex--;
            }

            private void MoveToFirstToken()
            {
                currentIndex = 1;
            }

            internal Argument Next()
            {
                if (HasToken())
                {
                    string currentToken = NextToken();
                    if (IsArgument(currentToken))
                    {
                        Argument argument = new Argument();
                        argument.Name = GetArgumentName(currentToken);
                        List<string> options = new List<string>();
                        while (HasToken())
                        {
                            currentToken = NextToken();
                            if (IsArgument(currentToken))
                            {
                                ComeBack();
                                break;
                            }
                            else
                            {
                                options.Add(currentToken);
                            }
                        }
                        argument.Options = options.ToArray();
                        return argument;
                    }
                }
                return null;
            }

            public ArgumentFactory(string[] rawArguments)
            {
                this.rawArguments = rawArguments;
                MoveToFirstToken();
            }
        }
    }
}