package virtualevo.client.session;

import virtualevo.client.userIO.UserIO;

/**
 * Handles everything to do with sessions 
 * 
 **/
public class SessionManager {
	private static String sessionKey;
	
	public static void startSession() {
		loadKey();
		if (verifyKey() != 0)
			if (generateKey() != 0)
				System.exit(0);
		
	}
	
	/**
	 * This methods allows the program to read the current session key.
	 * 
	 * @return Current session key
	 **/
	static private String getKey() {
		return sessionKey;
	}
	
	
	/**
	 * Checks whether the current key is valid. If it is non-existent or invalid the method returns false.
	 * 
	 * @return True if the key is valid, false otherwise.
	 **/
	private static int verifyKey() {
		// TODO
		return 0;
	}
	
	/**
	 * Loads a session key from file.
	 * 
	 * @return True if a key was successfully loaded, false otherwise.
	 */
	private static int loadKey() {
		// TODO
		return 0;
	}
	
	/**
	 * Gets a new session key from the server, either by having the user sign-in or sign-up.
	 * 
	 * @return True if a key was successfully generated, false otherwise.
	 */
	private static int generateKey() {
		switch (UserIO.getString("Do you wish to log-in or sign-up?", new String[]{"login", "signup", "exit"})) {
		case "login":
			return login();
			
		case "signup":
			return signup();

		case "exit":
		default:
			return 1;
		}
	}
	
	/**
	 * Logs the user in and retrieves a session key.
	 * 
	 * @return True if successfully logged in, false otherwise.
	 */
	private static int login() {
		// TODO
		return 0;
	}
	
	
	/**
	 * Signs the user up for a new account.
	 * 
	 * @return True if successfully signed up, false otherwise.
	 */
	private static int signup() {
		// TODO
		return 0;
	}
}
