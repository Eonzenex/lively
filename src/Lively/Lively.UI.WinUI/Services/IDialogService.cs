﻿using Lively.Models;
using System.Threading.Tasks;

namespace Lively.UI.WinUI.Services
{
    public interface IDialogService
    {
        Task<IDisplayMonitor> ShowDisplayChooseDialog();
        Task<ApplicationModel> ShowApplicationPickerDialog();
        Task ShowDialog(string message, string title, string primaryBtnText);
        Task<DialogResult> ShowDialog(object content,
            string title,
            string primaryBtnText,
            string secondaryBtnText,
            bool isDefaultPrimary = true);
        Task<string> ShowTextInputDialog(string title);
        Task ShowThemeDialog();

        public enum DialogResult
        {
            none,
            primary,
            seconday
        }
    }
}