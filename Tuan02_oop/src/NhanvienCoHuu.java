public class NhanvienCoHuu extends NhanVien {
    private double heSoLuong;
    private double phuCapChucVu;
    private static final double luongCoBan = 2500000.0;

    public NhanvienCoHuu(String maNhanVien, String gioiTinh, String sdt, String diaChi, String hoTen, double heSoLuong, double phuCapChucVu) {
        super(maNhanVien, hoTen, sdt, diaChi, gioiTinh);
        this.heSoLuong = heSoLuong;
        this.phuCapChucVu = phuCapChucVu;
    }

    public double tinhLuong() {
        return luongCoBan * this.heSoLuong + this.phuCapChucVu;
    }

    public void inThongTin() {
        super.inThongTin();
        System.out.println("He so luong: " + this.heSoLuong);
        System.out.printf("Phu cap chuc vu: %,d VND\n", (long)this.phuCapChucVu);
        System.out.printf("Luong: %,d VND\n", (long)this.tinhLuong());
    }
}
