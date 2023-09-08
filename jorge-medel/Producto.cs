using System;
namespace FinalProject
{
	public class Producto
	{
		private int _id;
		private string _description;
		private double _cost;
		private double _priceSale;
		private int _stock;
		private int _idUser;

		public Producto()
		{
			this._id = 0;
			this._description = string.Empty;
			this._cost = 0.0;
			this._priceSale = 0.0;
			this._stock = 0;
			this._idUser = 0;
		}
	}
}

