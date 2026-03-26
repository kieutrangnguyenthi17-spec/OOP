class NhanvienCongNhat extends NhanVien {
    private double tienCongNgay;
    private int soNgayLam;

    public NhanvienCongNhat(String maNhanVien, String gioiTinh, String sdt, String diaChi, String hoTen, double tienCongNgay, int soNgayLam) {
        super(maNhanVien, hoTen, sdt, diaChi, gioiTinh);
        this.tienCongNgay = tienCongNgay;
        this.soNgayLam = soNgayLam;
    }

    public double tinhLuong() {
        return this.tienCongNgay * (double)this.soNgayLam;
    }

    public void inThongTin() {
        super.inThongTin();
        System.out.printf("Tien cong ngay: %,f VND\n", this.tienCongNgay);
        System.out.println("So ngay lam: " + this.soNgayLam);
        System.out.printf("Luong: %,f VND\n", this.tinhLuong());
    }
}
