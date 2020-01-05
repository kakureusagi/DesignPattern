using System;

namespace Observer {

	class UserLogger : IUserObserver {

		public void OnUserDataChanged(User user) {
			Console.WriteLine($"[{nameof(UserLogger)}] UserId:{user.Id}");
		}
	}

}