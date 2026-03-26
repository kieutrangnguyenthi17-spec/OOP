class Main {
    public static void main(String[] args) {
        System.out.println("======= THONG TIN NHAN VIEN CONG NHAT =======");
        NhanVien nv1 = new NhanvienCongNhat("CH04", "Nam", "0245679980", "Phu Yen", "Nguyen Van A", 450000.0, 26);
        nv1.inThongTin();

        System.out.println("\n======= THONG TIN NHAN VIEN HOP DONG =======");
        NhanVien nv2 = new NhanvienHopDong("HK06", "Nu", "0997890456", "TP.HCM", "Tran Thi B", 150000.0, 25);
        nv2.inThongTin();

        System.out.println("\n======= THONG TIN NHAN VIEN CO HUU =======");
        NhanVien nv3 = new NhanvienCoHuu("CH01", "Nam", "0968686868", "Da Nang", "Le Van C", 3.1, 2500000.0);
        nv3.inThongTin();
    }
}
