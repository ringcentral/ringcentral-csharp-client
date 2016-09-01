using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class ContactTest : IDisposable
    {
        private RestClient rc;
        public ContactTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void ContactActions()
        {
            const string phoneNumber = "+15889546648";
            var addressBook = rc.Restapi().Account().Extension().AddressBook();

            var listt = await addressBook.Contact().List(new { phoneNumber = phoneNumber });
            foreach (var item in listt.records)
            {
                var temp = await addressBook.Contact(item.id).Delete();
            }

            // list
            var list = await addressBook.Contact().List();
            Assert.NotNull(list);
            Assert.Equal(1, list.paging.page);
            var total = list.paging.totalElements;

            // create
            var contact = await addressBook.Contact().Post(new Contact.PostRequest
            {
                firstName = "Tyler",
                lastName = "Long",
                homePhone = phoneNumber
            });
            Assert.NotNull(contact);
            Assert.Equal("Long", contact.lastName);

            // list again
            list = await addressBook.Contact().List();
            Assert.Equal(total + 1, list.paging.totalElements);

            Thread.Sleep(5000); // avoid 429

            // search
            list = await addressBook.Contact().List(new { phoneNumber = phoneNumber });
            Assert.Equal(1, list.paging.totalElements);
            var contactId = list.records[0].id;

            // update
            contact.lastName = "Liu";
            var contact2 = await addressBook.Contact(contactId).Put(contact);
            Assert.NotNull(contact2);
            Assert.Equal("Liu", contact2.lastName);

            // get
            var contact3 = await addressBook.Contact(contactId).Get();
            Assert.NotNull(contact3);
            Assert.Equal("Tyler", contact3.firstName);
            Assert.Equal("Liu", contact3.lastName);

            Thread.Sleep(5000); // avoid 429

            // delete
            var response = await addressBook.Contact(contactId).Delete();

            // search again
            list = await addressBook.Contact().List(new { phoneNumber = phoneNumber });
            Assert.Equal(0, list.paging.totalElements);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}