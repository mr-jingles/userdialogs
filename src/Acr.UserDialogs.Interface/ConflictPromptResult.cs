using System;
using System.Collections.Generic;
using System.Text;
using Couchbase.Lite;

namespace Acr.UserDialogs
{
    public class ConflictPromptResult : AbstractStandardDialogResult<Document>
    {
        public ConflictPromptResult(bool ok, Document choice) : base(ok, choice) { }
    }
}
