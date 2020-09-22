package chat;
import java.io.DataOutputStream;
import java.io.DataInputStream;
import java.net.Socket;
import java.util.*;
public class ChatClient {
 public static void main(String[] args) throws Exception{
	 Socket socket = new Socket("localhost",9000);
	 DataInputStream din = new DataInputStream(socket.getInputStream());
	 DataOutputStream dos = new DataOutputStream(socket.getOutputStream());
	 Scanner kb = new Scanner(System.in);
	 while(true) {
	 System.out.print("Client: ");
	 String msg = kb.nextLine();
	 dos.writeUTF("Client: "+msg);
	 dos.flush();
	 String st = din.readUTF();
	 System.out.println(st);
	 kb = kb.reset();
	 }
 }
}
