﻿using KanbanReporter.Business.Contracts;

namespace CanbanReporterCmd
{
    internal class ConsoleSettings : ISettings
    {
        private string[] args;

        public ConsoleSettings(string[] args)
        {
            this.args = args;
        }

        public string this[string key]
        {
            get
            {
                return string.Empty;
            }
        }
    }
}