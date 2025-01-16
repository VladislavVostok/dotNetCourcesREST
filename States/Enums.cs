namespace dotNetCources.States
{
	public enum Language
	{
		English,
		Spanish,
		French,
		Russian
	}

	public enum Level
	{
		Beginner,
		Intermediate,
		Advanced
	}

	public enum TeacherStatus
	{
		Draft,
		Disabled,
		Published
	}

	public enum PlatformStatus
	{
		Review,
		Disabled,
		Rejected,
		Draft,
		Published
	}

	public enum PaymentStatus
	{
		Processing,
		Rejected,
		Access
	}

	public enum NotificationType
	{
		Draft,
		Published
	}
}
