package ex;
import java.io.*;
public class chuoi {
	public String Inputchuoi() throws IOException
	{
		InputStreamReader luongvao = new InputStreamReader(System.in);
		BufferedReader dt = new BufferedReader(luongvao);
		String s =dt.readLine();
		return s;
	}
	public static void main (String ag[]) {
		String cd="";
		String cd1="";
		System.out.print("Nhap chuoi: ");
		chuoi dt= new chuoi();
		try { cd=dt.Inputchuoi();
		} catch (IOException e) {}
		System.out.print("Chuoi dao la: ");
		 for(int i=cd.length()-1;i>=0;i--) cd1=cd1+cd.charAt(i);
		 System.out.print(cd1);
	}

}
