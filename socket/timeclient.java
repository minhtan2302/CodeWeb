package socket;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.Socket;
public class timeclient {
public static void main (String[] args) throws Exception{
	Socket socket = new Socket("127.0.0.1",8889);
	DataInputStream din = new DataInputStream(socket.getInputStream());
	String time = din.readUTF();
	System.out.println(time);
	socket.close();
}
}
