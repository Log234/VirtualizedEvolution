package virtualevo.client;

public class Client {
	P2S serverConnection;
	P2P cloudConnection;
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
	}
	
	public void initialize() {
		serverConnection = new P2S();
		serverConnection.initialize();
		cloudConnection = new P2P();
	}
}
