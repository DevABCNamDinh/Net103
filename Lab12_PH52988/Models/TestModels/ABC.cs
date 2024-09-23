namespace Lab12_PH52988.Models.TestModels
{
    public partial class Human//partial class là một kỹ thuật lập trình cho phép viết 1 calss trên 2 file vạt lý khác nhau
    {
        public string CCCD { get; set; }

        public string Ten { get; set; }
        public string SDT { get; set; }
        public int Tuoi { get; set; }

            //@model = trong type cho phép trở trực tiếp với các thuộc tính của dối tượng khi được
            //truyền từ controller sang víew
            //đối tượng ở đây không phải chỉ là một object mà óc thể là một list object
            //1 view chỉ có thể trỏ tới 1 object duy nhất, nên nếu muốn nhiều ta có thể sử dụng thêm
            //viewbag, viewdata, session

    }

    public class Animal
    {
        public string Ten { get; set; }
        public int SoChan { get; set; }
    }
}
