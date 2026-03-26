package GIANGVIEN;

public abstract class GiangVien implements tinhLuong {
    // thuoc tinh
    private String maGiangVien;
    private String hoTen;
    private String hocVi;
    // ham dung - constructor
    public GiangVien(String maGiangVien, String hoTen, String hocVi){
        this.maGiangVien = maGiangVien;
        this.hoTen = hoTen;
        this.hocVi = hocVi;
    }
    //methods
    public void inThongTin(){
        System.out.println("In Thong Tin Giang Vien: ");
        System.out.println("Ma Giang Vien: "+ maGiangVien);
        System.out.println("Ho Ten: "+hoTen);
        System.out.println("Hoc Vi: "+hocVi);
    }

    @Override  // cho thay doi tu lop con
    public double Luong() {
        return Luong();
    }
    //getter - encapsulation public
    public String getMaGiangVien() {
        return maGiangVien;
    }
}
