package GIANGVIEN;

public class GiangVienThinhGiang extends GiangVien implements tinhLuong {

        // thuoc tinh
        private int soGioday;
        private double donGiaMoiGio;
        private int soBuoiDayTrucTiep;
        private double phuCapMoiBuoi;
        public GiangVienThinhGiang(String maGiangVien, String hoTen, String hocVi,int soGioday, double donGiaMoiGio,int soBuoiDayTrucTiep,double phuCapMoiBuoi) {
            super(maGiangVien, hoTen, hocVi);
            this.soGioday = soGioday;
            this.donGiaMoiGio = donGiaMoiGio;
            this.soBuoiDayTrucTiep = soBuoiDayTrucTiep;
            this.phuCapMoiBuoi = phuCapMoiBuoi;
        }

        @Override
        public double Luong(){
            double Luong=soGioday*donGiaMoiGio+soBuoiDayTrucTiep*phuCapMoiBuoi;
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

