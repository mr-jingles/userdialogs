using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acr.UserDialogs

{

    public class UserDialogsImpl : AbstractUserDialogs

    {
        public override IDisposable ActionSheet(ActionSheetConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Alert(AlertConfig config)
        {
            var dlg = new TaskDialog
            {
                WindowTitle = config.Title,
                Content = config.Message,
                Buttons =
                {
                    new TaskDialogButton(config.OkText)
                }
            };
            dlg.ShowDialog();
            return new DisposableAction(dlg.Dispose);
        }

        public override IDisposable Confirm(ConfirmConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable DatePrompt(DatePromptConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Login(LoginConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Prompt(PromptConfig config)
        {
            throw new NotImplementedException();
        }

        public override void ShowError(string message, int timeoutMillis)
        {
            var a = Alert(new AlertConfig
            {
                Title = "Error",
                Message = message
            });

            a.Dispose();
        }

        public override void ShowImage(global::Splat.IBitmap image, string message, int timeoutMillis)
        {
            throw new NotImplementedException();
        }

        public override void ShowSuccess(string message, int timeoutMillis)
        {
            throw new NotImplementedException();
        }

        public override IDisposable TimePrompt(TimePromptConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Toast(ToastConfig config)
        {
            throw new NotImplementedException();
        }

        protected override IProgressDialog CreateDialogInstance(ProgressDialogConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable ConflictPrompt(ConflictPromptConfig config)
        {
            var dlg = new ConflictDialog(config.Conflict)
            {
                Title = config.Title
                // OkText = config.OkText,
                //CancelText = config.CancelText,
            };

            dlg.ShowDialog();
            config.OnAction(new ConflictPromptResult(dlg.WasOk, dlg.SelectedDocument));
            return new DisposableAction(dlg.Dispose);
        }

    }

}

