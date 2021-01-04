using DataAccess;

namespace GoldenShoe.ViewModelActioners
{
    public class ShoppingCartViewModelActioner
    {
        private readonly Context _context;
        public ShoppingCartViewModelActioner(Context context)
        {
            _context = context;
        }

        public bool AddVoucher(string voucherId)
        {
            var repo = new DataRepository(_context);

            if (repo.VoucherExists(voucherId))
            {
                if (repo.VoucherInUseExists())
                {
                    repo.SwitchOffVoucher();
                }

                repo.UseVoucher(voucherId);

                return true;
            }
            
            return false; 
        }
    }
}
