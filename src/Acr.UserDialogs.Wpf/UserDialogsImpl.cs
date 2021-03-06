﻿using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acr.UserDialogs

{

    public class UserDialogsImpl : AbstractUserDialogs

    {
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



        public override IDisposable ActionSheet(ActionSheetConfig config)
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
            var dlg = new TaskDialog
            {
                WindowTitle = config.Title,
                Content = config.Message,
                Buttons =
                {
                    new TaskDialogButton(config.CancelText)
                    {
                        ButtonType = ButtonType.Cancel
                    },
                    new TaskDialogButton(config.OkText)
                    {
                        ButtonType = ButtonType.Ok
                    }
                }
            };
            dlg.ButtonClicked += (sender, args) =>
            {
                var ok = ((TaskDialogButton)args.Item).ButtonType == ButtonType.Ok;
                config.OnAction(ok);
            };
            return new DisposableAction(dlg.Dispose);
        }


        public override IDisposable DatePrompt(DatePromptConfig config)
        {
            throw new NotImplementedException();
        }


        public override IDisposable TimePrompt(TimePromptConfig config)
        {
            throw new NotImplementedException();
        }


        public override IDisposable Login(LoginConfig config)
        {
            var dlg = new CredentialDialog
            {
                //UserName = config.LoginValue ?? String.Empty,
                WindowTitle = config.Title,
                Content = config.Message,
                ShowSaveCheckBox = false
            };
            //dlg.MainInstruction
            dlg.ShowDialog();

            config.OnAction(new LoginResult(
                true,
                dlg.UserName,
                dlg.Password
            ));
            return new DisposableAction(dlg.Dispose);
        }


        public override IDisposable Prompt(PromptConfig config)
        {
            throw new NotImplementedException();

            var dlg = new InputDialog
            {
                Title = config.Title,
                Text = config.Text,
                OkText = config.OkText,
                CancelText = config.CancelText,
                IsPassword = config.InputType == InputType.Password
            };

            dlg.ShowDialog();
            config.OnAction(new PromptResult(dlg.WasOk, dlg.Text));

            return new DisposableAction(dlg.Dispose);

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
            var vm = new ConflictDialogViewModel
            {
                //no properties which we can set here from config currently
            };

            vm.Base.Add(config.Conflict.Base);
            vm.LocalVersion.Add(config.Conflict.Mine);
            vm.Theirs.Add(config.Conflict.Theirs);

            vm.SubmitConflictCommand = new Command(() =>
                    config.OnAction?.Invoke(new ConflictPromptResult(vm.WasOk, vm.SelectedConflict))
            );

            /* Excerpt from previous Handle OK Click Event
            e.Handled = true;
            WasOk = !((Button)sender).IsCancel;
            Close();
            */

            var dlg = new ConflictDialog() { DataContext = vm };
            dlg.ShowDialog();
<<<<<<< HEAD
            config.OnAction(new ConflictPromptResult(dlg.WasOk, dlg.SelectedDocument));
=======
>>>>>>> refs/remotes/origin/master
            return new DisposableAction(dlg.Dispose);

            /*
            return this.DispatchAndDispose(
              () => dlg.ShowAsync(),
              dlg.Hide
          );*/
        }

        protected virtual IDisposable DispatchAndDispose(Action dispatch, Action dispose)
        {
            this.Dispatch(dispatch);
            return new DisposableAction(() =>
            {
                try
                {
                    this.Dispatch(dispose);
                }
                catch { }
            });
        }

        protected virtual void Dispatch(Action action)
        {
            //this.UiDispatcher.RunAsync(CoreDispatcherPriority.Normal, () => action());
            //CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => action());
        }

    }

}
