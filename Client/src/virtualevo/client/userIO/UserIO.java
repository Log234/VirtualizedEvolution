package virtualevo.client.userIO;

public class UserIO {

	/**
	 * Queries the user with msg and returns the user's reply.
	 * 
	 * @param msg
	 *            - The query for the user.
	 * @return User reply;
	 */
	public static String getString(String msg) {
		String reply = "";

		while (reply == "") {
			System.out.print(msg);
			reply = System.console().readLine().trim();
		}

		return reply;
	}
	
	/**
	 * Queries the user with msg and checks the reply against a number of alternatives.
	 * 
	 * @param msg - The query for the user.
	 * @param alternatives - The allowed alternatives.
	 * @return User reply;
	 */
	public static String getString(String msg, String[] alternatives) {
		boolean finished = false;
		String reply = "";

		while (!finished) {
			System.out.print(msg + "(");
			for (int i = 0; i < alternatives.length; i++) {
				if (i != alternatives.length - 1)
					System.out.print(alternatives[i] + ", ");
				else
					System.out.print(alternatives[i] + "): ");
			}
			reply = System.console().readLine().trim().toLowerCase();
			
			if (reply != "") {
				for (String alt : alternatives) {
					if (reply.equals(alt))
						finished = true;
				}
			}
			if (!finished) {
				System.out.print("Please enter one of the permitted alternatives: ");
				for (int i = 0; i < alternatives.length; i++) {
					if (i != alternatives.length - 1)
						System.out.print(alternatives[i] + "/");
					else
						System.out.println(alternatives[i] + ".");
				}
			}
			
		}

		return reply;
	}
	
	/**
	 * Queries the user with msg and interprets the result as a boolean.
	 * 
	 * @param msg
	 * @return True if the answer was yes, false otherwise.
	 */
	public static boolean getBoolean(String msg) {
		String result = getString(msg, new String[]{"yes", "no"});
		switch (result) {
		case "yes":
			return true;

		case "no":
		default:
			return false;
		}
	}
}
