using Microsoft.JSInterop;
using System.Text.RegularExpressions;

namespace POD_App.Services
{
    public class Messages
    {


        IJSRuntime _jSRuntime1;
        public Messages(IJSRuntime jSRuntime)
        {
            _jSRuntime1 = jSRuntime;
        }

        public async Task ShowSuccessAlert(string MessageContent)
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.showSuccess", "Operation successful", MessageContent);
        }

        public async Task ShowRequirdAlert(string MessageContent)
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.showError", "Warning ", MessageContent);

        }

        public async Task ShowWarning(string MessageContent)
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.showError", "Warning ", MessageContent);

        }

        public async Task ShowErrorAlert(string MessageContent)
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.showError", "Went Wrong", MessageContent);

        }

        public async Task ShowSuccessAlert()
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.showSuccess", "Success", "Operation successfull");
        }

        public async Task ShowRequirdAlert()
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.showError", "warning", "Please fill in all required fields");

        }

        public async Task ShowErrorAlert()
        {
            await Loading("", "Loading.......", 0); await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.showError", "Error", "Went Wrong");

        }

        public async Task UnauthorizedAlert()
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.Unauthorized", "Session expired", "Your session has expired. Please login again.");
        }

        public async Task Loading(string title, string text, int duration)
        {
            await _jSRuntime1.InvokeVoidAsync("sweetAlertInterop.ShowLoading", title, text, duration);

        }

        public bool IsValidEmail(string email)
        {
            // Regular expression pattern for a basic email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression to match 10-digit phone numbers
            string pattern = @"^\d{10}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }

    }
}
