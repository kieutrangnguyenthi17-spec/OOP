package GIANGVIEN;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        GiangVien[] ds = new GiangVien[4];
        ds[0] = new GiangVienCoHuu("GV01", "Nguyen Van A", "TS", 10000000, 2000000, 40, 45);
        ds[1] = new GiangVienCoHuu("GV02", "Tran Thi B", "ThS", 9000000, 1500000, 35, 35);
        ds[2] = new GiangVienThinhGiang("GV03", "Le Van C", "ThS", 50, 20000, 5, 50000);
        ds[3] = new GiangVienThinhGiang("GV04", "Pham Thi D", "TS", 40, 25000, 3, 70000);
        double tongLuong = 0; // tong luong
        GiangVien gvMax = ds[0]; // giang vien co luong cao nhat
        for (GiangVien gv : ds) {
            gv.inThongTin();
            gv.Luong();
            tongLuong += gv.Luong();
            if (gv.Luong() > gvMax.Luong()) {
                gvMax = gv;
            }
        }
     System.out.println("Tong quy luong: "+tongLuong);
     System.out.println("Giang Vien co luong cao nhat: "+gvMax.Luong());
     System.out.println("Luong: "+gvMax.Luong());
    }
}