package virtualevo.client;

import virtualevo.client.session.SessionManager;

public class P2S {
	// TODO Check for updates

	public void initialize() {
		establishConnection();
	}

	private void establishConnection() {
		// TODO Connect to server
		SessionManager.startSession();
	}
}
