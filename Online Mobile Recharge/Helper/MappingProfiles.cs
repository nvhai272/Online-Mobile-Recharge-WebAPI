﻿using AutoMapper;
using Online_Mobile_Recharge.DTO.Request;
using Online_Mobile_Recharge.DTO.Response;
using Online_Mobile_Recharge.Models;
namespace Online_Mobile_Recharge.MappingProfiles
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			// thằng userService là bảng trung gian 

			CreateMap<User, UserRequest>().ReverseMap();
			CreateMap<PaymentMethod, PaymentMethodRequest>().ReverseMap();
			CreateMap<Transaction, TransactionRequest>().ReverseMap();
			CreateMap<UserPaymentInfo, UserPaymentInfoRequest>().ReverseMap();
			CreateMap<Feedback, FeedbackRequest>().ReverseMap();
			CreateMap<Operator, OperatorRequest>().ReverseMap();
			CreateMap<Service, ServiceRequest>().ReverseMap();
			CreateMap<RechargePlan, RechargePlanRequest>().ReverseMap();
			CreateMap<RechargePlanType, RechargePlanTypeRequest>().ReverseMap();
			CreateMap<UserService, UserServiceRequest>().ReverseMap();


			CreateMap<User, UserResponse>().ReverseMap();
			CreateMap<PaymentMethod, PaymentMethodResponse>().ReverseMap();
			CreateMap<Service, ServiceResponse>().ReverseMap();
			CreateMap<UserPaymentInfo, UserPaymentInfoResponse>().ReverseMap();
			CreateMap<Feedback, FeedbackResponse>().ReverseMap();
			CreateMap<Operator, OperatorResponse>().ReverseMap();
			CreateMap<Transaction, TransactionResponse>().ReverseMap();
			CreateMap<RechargePlan, RechargePlanResponse>().ReverseMap();
			CreateMap<RechargePlanType, RechargePlanTypeResponse>().ReverseMap();
			CreateMap<UserService, UserServiceResponse>().ReverseMap();


		}
	}
}
