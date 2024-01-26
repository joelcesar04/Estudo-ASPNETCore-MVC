using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public CarrinhoViewComponent()
        {
            ItensCarrinho = 3;
        }
        public int ItensCarrinho { get; set; }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItensCarrinho);
        }
    }
}
