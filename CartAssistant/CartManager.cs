﻿using System.Collections.Generic;
using System.Linq;

namespace CartAssistant
{
    public interface ICartManager
    {
        public void Add(string name, int quantity);
        public void Edit(int index, int quantity);
        public void Remove(int index);
        IList<CartItem> GetList();
    }
    public class CartManager : ICartManager
    {
        public IList<CartItem> itemsInCart = new List<CartItem>();
        public void Add(string name, int quantity)
        {
            var result = itemsInCart.FirstOrDefault(CartItem => CartItem.Name == name);        
            if (result == null)
            {
                itemsInCart.Add(new CartItem(name, quantity));
                return;
            }
            result.Quantity += quantity;
        }
        public void Edit(int index, int quantity)
        {
            itemsInCart[index].Quantity = quantity;
        }
        public void Remove(int index)
        {
            itemsInCart.RemoveAt(index);
        }
        public IList<CartItem> GetList()
        {
            return itemsInCart;
        }
    }
}