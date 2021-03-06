﻿namespace Ravelin.Models.Events
{
	public class TransactionEvent : Event, IPaymentMethodEvent
	{
		/// <summary>
		/// Customer performing the transaction
		/// </summary>
		public string CustomerId { get; set; }

		/// <summary>
		/// A session ID, if the customer has not logged in yet
		/// </summary>
		public string TempCustomerId { get; set; }

		/// <summary>
		/// Payment method used for this transaction
		/// </summary>
		public PaymentMethod PaymentMethod { get; set; }

		/// <summary>
		/// If a payment method was already added for this user in a previous event, it can be referenced here.
		/// Mutually exclusive with the PaymentMethod field.
		/// </summary>
		public string PaymentMethodId { get; set; }

		/// <summary>
		/// Order this transaction is (partially) resolving
		/// </summary>
		public string OrderId { get; set; }

		/// <summary>
		/// The transaction which was committed to the PSP, including the response from the PSP
		/// </summary>
		public Transaction Transaction { get; set; }
	}
}
