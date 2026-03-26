class NhanvienHopDong extends NhanVien {
    private double luongThang;
    private int soNgayCong;

    public NhanvienHopDong(String maNhanVien, String gioiTinh, String sdt, String diaChi, String hoTen, double luongThang, int soNgayCong) {
        super(maNhanVien, hoTen, sdt, diaChi, gioiTinh);
        this.luongThang = luongThang;
        this.soNgayCong = soNgayCong;
    }

    public double tinhLuong() {
        return this.luongThang / 26.0 * (double)this.soNgayCong;
    }

    public void inThongTin() {
        super.inThongTin();
        System.out.printf("Luong thang: %,f VND\n", this.luongThang);
        System.out.println("So ngay cong: " + this.soNgayCong);
        System.out.printf("Luong thuc nhan: %,f VND\n", this.tinhLuong());
    }
}
