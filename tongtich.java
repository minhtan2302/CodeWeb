package ex;
import java.io.*;

public class tongtich 
{
	public int Input() throws IOException{
		InputStreamReader luongvao = new InputStreamReader(System.in);
		BufferedReader br= new BufferedReader(luongvao);
		String s =br.readLine();
		return Integer.parseInt(s);
		// muon ra so nguyen parseInt
		//muon ra so thuc parseFloat, Double
		// muon ra  chuoi return s 
	}
public void ttccs(int m) {
	int S=0; 
	int P=1;
	while(m!=0) {
	S+=m%10;
	P*=m%10;
	m/=10;
	}
	System.out.println("Tong cac chu so la :" +S);
	System.out.println("Tich cac chu so la :" +P);
}
public static void main (String argx[]) {
	tongtich dt = new tongtich();
	int m=0;
	try {
		do {
			System.out.print("Nhap so nguyen duong: ");
			m=dt.Input();	
		}while(m<=0); 
	}catch(Exception e) {}
	System.out.println("So da nhap la: " +m);
	dt.ttccs(m);
}
}
