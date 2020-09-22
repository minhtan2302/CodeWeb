package socket;

import java.io.DataOutputStream;
import java.net.*;
import java.util.Date;
public class timeserver {
	public static void main(String[]args) throws Exception{
		ServerSocket sv = new ServerSocket(8889);
		System.out.println("Server is started");
		while(true) {
			Socket socket = sv.accept();
			DataOutputStream dos = new DataOutputStream(socket.getOutputStream());
			String time = new Date().toString();
			dos.writeUTF("Server tra lai Date=" +time);
			socket.close();
		}
	}

}
