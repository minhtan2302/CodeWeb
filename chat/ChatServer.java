package chat;
import java.io.*;
import java.util.*;
import java.net.*;
public class ChatServer {
public static void main (String[] args) throws Exception{
	ServerSocket server = new ServerSocket(9000);
	System.out.println("Sever is started");
	Socket socket = server.accept();
	DataOutputStream dos = new DataOutputStream(socket.getOutputStream());
	DataInputStream din = new DataInputStream(socket.getInputStream());
	Scanner kb = new Scanner(System.in);
	while(true) {
		String st = din.readUTF();
		System.out.println(st);
		System.out.println("Server: ");
		String msg = kb.nextLine();
		dos.writeUTF("Server: "+msg );
		dos.flush();
		kb=kb.reset();
	}
}
}
