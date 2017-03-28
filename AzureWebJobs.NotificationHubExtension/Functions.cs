using System.IO;
using AzureWebJobs.NotificationHubExtension.Extensions;
using Microsoft.Azure.NotificationHubs;
using Microsoft.Azure.WebJobs;

namespace AzureWebJobs.NotificationHubExtension
{
	public class Functions
	{
		// This function will get triggered/executed when a new message is written 
		// on an Azure Queue called queue.
		public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log, [NotificationHub] out Notification notification)
		{
			log.WriteLine(message);

			notification = new GcmNotification(message.ToGcmPayload());
		}
	}
}
