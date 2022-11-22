<template>
  <table id="tblUsers">
    <thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
    </tr>
    </thead>
    <!-- These are the boxes where user inputs search terms -->
    <!-- V-model = allows for two-way binding -->
    <tbody>
      <tr>
        <td><input type="text" id="firstNameFilter" v-model="search.firstName"/></td>
        <td><input type="text" id="lastNameFilter" v-model="search.lastName"/></td>
        <td><input type="text" id="usernameFilter" v-model="search.username"/></td>
        <td><input type="text" id="emailFilter" v-model="search.emailAddress" /></td>
        <td>
          <select id="statusFilter" v-model="search.status">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Inactive">Inactive</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <!-- user listing -->

      <tr v-for="user in filteredList" v-bind:key="user" v-bind:class = "{'disabled': search.status === 'Disabled'}">
        <td>{{user.firstName}}</td>
        <td>{{user.lastName}}</td>
        <td>{{user.username}}</td>
        <td>{{user.emailAddress}}</td>
        <td>{{user.status}}</td>
      </tr>


    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
  data() {
    return {
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Inactive' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Inactive' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }

      ],
      search: 
        {firstName: '', lastName: '', username: '', emailAddress: '', status: ''}
    }
  },

  computed: {
    filteredList() {
      let filterItem = this.users.filter((item) => {

        return item.firstName.toLowerCase().includes(this.search.firstName.toLowerCase()) 
        && item.lastName.toLowerCase().includes(this.search.lastName.toLowerCase()) 
        && item.username.toLowerCase().includes(this.search.username.toLowerCase()) 
        && item.emailAddress.toLowerCase().includes(this.search.emailAddress.toLowerCase()) 
        && item.status.includes(this.search.status);
      })
      return filterItem;
    }
  }


}
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif
}
th {
  text-transform: uppercase
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input, select {
  font-size: 16px;
}
</style>
