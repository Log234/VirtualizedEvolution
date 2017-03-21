package virtualevo.client;

import virtualevo.client.session.SessionManager;

public class P2S {
	SessionManager session;
	
	public void initialize() {
		establishConnection();
		checkUpdates();
		session = new SessionManager();
	}

	private void establishConnection() {
		// TODO Connect to server
	}
	
	private void checkUpdates() {
		// TODO Check for updates
	}
}
