using Newtonsoft.Json;

namespace AzureWebJobs.NotificationHubExtension.Extensions
{
	public static class PlatformNotificationsExtensions
	{
		public static string ToGcmPayload(this string message)
		{
			var gcmPayloadModel = new
			{
				data = new
				{
					message = message
				}
			};

			return JsonConvert.SerializeObject(gcmPayloadModel);
		}
	}
}