package ex;

public class ex1 {
	int maso;
	String hoten;
	String diachi;
	public void insert (int mso, String hoten, String diachi) {
		maso = mso;
		this.hoten = hoten;
		this.diachi= diachi;
	}
	public void show() {
		System.out.println(maso);
		System.out.println(hoten);
		System.out.println(diachi);
	}
	public static void main (String[] args) {
		ex1 dt1 = new ex1();
		dt1.insert(26, "Phu Chi Minh Tan", "Hue");
		dt1.show();
		ex1 dt2 = new ex1();
		dt2.insert(81, "Ho Thi My Duyen", "Hue luon");
		dt2.show();
	}
}
