package GIANGVIEN;

public class GiangVienCoHuu extends GiangVien implements tinhLuong {
    // thuoc tinh
    private double luongCoBanThang;
    private double phuCapTrachNhiem;
    private int soGioQuyDinh;
    private int soGioThucDay;

    public GiangVienCoHuu(String maGiangVien, String hoTen, String hocVi,double luongCoBanThang, double phuCapTrachNhiem,int soGioQuyDinh,int soGioThucDay) {
        super(maGiangVien, hoTen, hocVi);
        this.luongCoBanThang = luongCoBanThang;
        this.phuCapTrachNhiem = phuCapTrachNhiem;
        this.soGioQuyDinh = soGioQuyDinh;
        this.soGioThucDay = soGioThucDay;
    }


    @Override
    public double Luong(){
        double Luong=luongCoBanThang+phuCapTrachNhiem;
        if(soGioThucDay>soGioQuyDinh){
           Luong+=(soGioThucDay-soGioQuyDinh)*50000;
        }
        return Luong;
    }
    @Override
    public void inThongTin(){
        super.inThongTin();
        System.out.println("Luong cho Giang Vien: "+Luong());
    }
    @Override
    public String toString() {
        return super.getMaGiangVien();
    }
}
