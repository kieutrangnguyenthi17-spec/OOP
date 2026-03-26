public abstract class NhanVien {
    private String maNhanVien;
    protected String hoTen;
    private String gioiTinh;
    private String sdt;
    protected String diaChi;

    public NhanVien(String maNhanVien, String hoTen, String sdt, String diaChi, String gioiTinh) {
        this.maNhanVien = maNhanVien;
        this.hoTen = hoTen;
        this.sdt = sdt;
        this.diaChi = diaChi;
        this.gioiTinh = gioiTinh;
    }

    public void inThongTin() {
        System.out.println("Ma nhan vien: " + this.maNhanVien);
        System.out.println("Ho va ten: " + this.hoTen);
        System.out.println("Gioi tinh: " + this.gioiTinh);
        System.out.println("La nu: " + this.gioiTinh);
        System.out.println("Dia chi: " + this.diaChi);
    }

    public abstract double tinhLuong();
}
