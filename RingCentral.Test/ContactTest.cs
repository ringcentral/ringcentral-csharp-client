using Xunit;
using System.Threading;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class ContactTest
    {
        private RestClient rc;
        public ContactTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void ContactActions()
        {
            const string phoneNumber = "+15889546648";
            var addressBook = rc.Restapi().Account().Extension().AddressBook();

            // list
            var list = addressBook.Contact().List().Result;
            Assert.NotNull(list);
            Assert.Equal(1, list.paging.page);
            var total = list.paging.totalElements;

            // create
            var contact = addressBook.Contact().Post(new Contact.PostRequest
            {
                firstName = "Tyler",
                lastName = "Long",
                homePhone = phoneNumber
            }).Result;
            Assert.NotNull(contact);
            Assert.Equal("Long", contact.lastName);

            // list again
            list = addressBook.Contact().List().Result;
            Assert.Equal(total + 1, list.paging.totalElements);

            Thread.Sleep(5000); // avoid 429

            // search
            list = addressBook.Contact().List(new { phoneNumber = phoneNumber }).Result;
            Assert.Equal(1, list.paging.totalElements);
            var contactId = list.records[0].id;

            // update
            contact.lastName = "Liu";
            var contact2 = addressBook.Contact(contactId.ToString()).Put(contact).Result;
            Assert.NotNull(contact2);
            Assert.Equal("Liu", contact2.lastName);

            // get
            var contact3 = addressBook.Contact(contactId.ToString()).Get().Result;
            Assert.NotNull(contact3);
            Assert.Equal("Tyler", contact3.firstName);
            Assert.Equal("Liu", contact3.lastName);

            Thread.Sleep(5000); // avoid 429

            // delete
            var response = addressBook.Contact(contactId.ToString()).Delete().Result;

            // search again
            list = addressBook.Contact().List(new { phoneNumber = phoneNumber }).Result;
            Assert.Equal(0, list.paging.totalElements);
        }
    }
}