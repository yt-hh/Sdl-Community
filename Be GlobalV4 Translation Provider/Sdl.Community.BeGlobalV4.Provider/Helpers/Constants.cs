﻿namespace Sdl.Community.BeGlobalV4.Provider.Helpers
{
	public class Constants
	{
		public readonly string PluginName = "SDL Machine Translation Cloud provider";
		public readonly string SDLMachineTranslationCloud = "SDLMachineTranslationCloud";
		public readonly string SDLMTCloud = "SDL Machine Translation Cloud";
		public readonly string SDLCommunity = "SDL Community";
		public readonly string TraceId = "Trace-ID";
		public readonly string FAILED = "FAILED";
		public readonly string INIT = "INIT";
		public readonly string DONE = "DONE";
		public readonly string TRANSLATING = "TRANSLATING";
		public readonly string Authorization = "Authorization";
		public readonly string SDLMachineTranslationCloudProvider = "SDLMachineTranslationCloudProvider";
		public readonly string ClientAuthentication = "Client Authentication";
		public readonly string UserAuthentication = "User Authentication";
		public readonly string Client = "Client";
		public readonly string User = "User";
		public readonly string PasswordBox = "PasswordBox";
		public readonly string NullValue = "Value cannot be null.";
		public readonly string Red = "Red";
		public readonly string Green = "Green";
		public readonly string PrintMTCodes = "Printing MT Codes";

		// Excel MTCodes values
		public readonly string ExcelSheet = "Sheet1";

		// Logging
		public readonly string TranslateTextMethod = "Translate text method: ";
		public readonly string SubscriptionInfoMethod = "Subscription info method: ";
		public readonly string WaitTranslationMethod = "Wait for translation method: ";
		public readonly string ErrorCode = "Error code:";
		public readonly string EditWindow = "Edit window:";
		public readonly string Browse = "Browse:";
		public readonly string SupportsLanguageDirection = "SupportsLanguageDirection: ";
		public readonly string BeGlobalV4Translator = "BeGlobalV4Translator constructor: ";
		public readonly string GetClientInformation = "GetClientInformation method: ";
		public readonly string GetUserInformation = "GetUserInformation method: ";
		public readonly string IsWindowValid = "Is window valid method: ";
		public readonly string IsEmailValid = "IsEmailValid method: ";
		public readonly string ExcelExecuteAction = "BeGlobalExcelAction Execute method: ";
		public readonly string WriteExcelLocally = "WriteExcelLocally method: ";
		public readonly string AddMTCode = "AddMTCode method: ";
		public readonly string RemoveMTCode = "RemoveMTCode method: ";
		public readonly string FormatLanguageName = "FormatLanguageName method: ";

		// Messages
		public readonly string ForbiddenLicense = "Forbidden: Please check your license";
		public readonly string TokenFailed = "Acquiring token failed";
		public readonly string CredentialsValidation = "Please fill the credentials fields!";
		public readonly string CredentialsNotValid = "Please verify your credentials!";
		public readonly string CredentialsAndInternetValidation = "The MTCloud host could not be reached and setups cannot be saved. Please verify your credentials and internet connection, and ensure you are able to connect to the server from this computer.";
		public readonly string InternetConnection = "The MTCloud host could not be reached. Please check the internet connection and ensure you are able to connect to the server from this computer.";
		public readonly string MTCodeEmptyValidation = "MTCode (locale) cannot be emtpy! Please fill the value in order to be added to MTLanguageCodes.xlsx file.";
		public readonly string SuccessfullyUpdatedMessage = "MT Code was successfully updated within MTLanguageCodes.xlsx file.";
	}
}