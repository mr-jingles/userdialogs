using System;
using System.Collections.Generic;
using System.Text;
using Couchbase.Lite;

namespace Acr.UserDialogs
{
    public class ConflictPromptConfig
    {
        public ConflictPromptConfig() { }

        public static string DefaultOkText { get; set; }
        public static string DefaultCancelText { get; set; }
        public Conflict Conflict { get; set; }
        public Action<ConflictPromptResult> OnAction { get; set; }
        public string Title { get; set; }

        public ConflictPromptConfig SetAction(Action<ConflictPromptResult> action) {
            OnAction = action;
            return this;
        }

        public ConflictPromptConfig SetConflict(Conflict conflict) {
            Conflict = conflict;
            return this;
        }

        public ConflictPromptConfig SetTitle(string title) {
            Title = title;
            return this;
        }
    }
}
