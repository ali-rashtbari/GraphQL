using GraphQL.Data.Entities;

namespace GraphQL.GraphTypes
{
    public class UserType : ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Field(u => u.Id).Type<NonNullType<IdType>>();
            descriptor.Field(u => u.FirstName).Type<NonNullType<StringType>>();
            descriptor.Field(u => u.LastName).Type<NonNullType<StringType>>();
            descriptor.Field(u => u.Email).Type<NonNullType<StringType>>();
            descriptor.Field(u => u.BirthDate).Type<NonNullType<DateType>>();
            descriptor.Field(u => u.FullName).Type<NonNullType<StringType>>();
        }
    }
}
