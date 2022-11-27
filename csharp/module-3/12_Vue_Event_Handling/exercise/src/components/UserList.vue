<template>
  <div class="container">
    <table id="tblUsers">
      <thead>
        <tr>
          <th>&nbsp;</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Username</th>
          <th>Email Address</th>
          <th>Status</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>
            <input type="checkbox" id="selectAll" v-on:click="counter += 1; if (counter % 2 === 0) {checkAllBoxes} else{uncheckAllBoxes}" />
          </td>
          <td>
            <input type="text" id="firstNameFilter" v-model="filter.firstName" />
          </td>
          <td>
            <input type="text" id="lastNameFilter" v-model="filter.lastName" />
          </td>
          <td>
            <input type="text" id="usernameFilter" v-model="filter.username" />
          </td>
          <td>
            <input type="text" id="emailFilter" v-model="filter.emailAddress" />
          </td>
          <td>
            <select id="statusFilter" v-model="filter.status">
              <option value>Show All</option>
              <option value="Active">Active</option>
              <option value="Disabled">Disabled</option>
            </select>
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr
          v-for="user in filteredList"
          v-bind:key="user.id"
          v-bind:class="{ disabled: user.status === 'Disabled' }"
        >
          <td>
            <!-- **Step 3: "Bind the checked value to if the user's ID is in the selectedUserID's array" ?? (what does this mean)-->
            <input type="checkbox" class="userCheck" v-bind:id="user.id" v-bind:value="user.id" v-on:click="addRemoveToSelectedUserIds($event); checkSelectAll;" />
          </td>
          <td>{{ user.firstName }}</td>
          <td>{{ user.lastName }}</td>
          <td>{{ user.username }}</td>
          <td>{{ user.emailAddress }}</td>
          <td>{{ user.status }}</td>
          <td>
            <!-- I got rid of this button and made two buttons instead -->
            <!-- <button class="btnEnableDisable">Enable or Disable</button> -->
            <!-- **Step 2: Flipstatus function (change user's status from active -> disabled) doesn't work... -->
            <button v-show = "user.status === 'Disabled'" v-bind:id="user.id" v-on:click="flipStatus($event)">Enable</button>
            <button v-show = "user.status === 'Active'" v-bind:id="user.id" v-on:click="flipStatus($event)">Disable</button>
          </td>
        </tr>
      </tbody>
    </table>

    <div class="all-actions">
      <button v-bind:disabled="actionButtonDisabled" v-on:click="enableSelectedUsers">Enable Users</button>
      <button v-bind:disabled="actionButtonDisabled" v-on:click="disableSelectedUsers">Disable Users</button>
      <button v-bind:disabled="actionButtonDisabled"  v-on:click="deleteSelectedUsers">Delete Users</button>
    </div>

    <button v-on:click="showForm += 1">Add New User</button>

    <form id="frmAddNewUser" v-show="showForm % 2 != 0" v-on:submit.prevent="saveUser">
      <div class="field">
        <label for="firstName">First Name:</label>
        <input type="text" name="firstName" v-model="newUser.firstName"/>
      </div>
      <div class="field">
        <label for="lastName">Last Name:</label>
        <input type="text" name="lastName" v-model="newUser.lastName"/>
      </div>
      <div class="field">
        <label for="username">Username:</label>
        <input type="text" name="username" v-model="newUser.username" />
      </div>
      <div class="field">
        <label for="emailAddress">Email Address:</label>
        <input type="text" name="emailAddress"  v-model="newUser.emailAddress" />
      </div>
      <button type="submit" class="btn save">Save User</button>
    </form>
  </div>
</template>

<script>
export default {
  name: "user-list",
  data() {
    return {
      filter: {
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: ""
      },
      nextUserId: 7,
      newUser: {
        id: this.nextUserId,
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "Active"
      },
      users: [
        {
          id: 1,
          firstName: "John",
          lastName: "Smith",
          username: "jsmith",
          emailAddress: "jsmith@gmail.com",
          status: "Active"
        },
        {
          id: 2,
          firstName: "Anna",
          lastName: "Bell",
          username: "abell",
          emailAddress: "abell@yahoo.com",
          status: "Active"
        },
        {
          id: 3,
          firstName: "George",
          lastName: "Best",
          username: "gbest",
          emailAddress: "gbest@gmail.com",
          status: "Disabled"
        },
        {
          id: 4,
          firstName: "Ben",
          lastName: "Carter",
          username: "bcarter",
          emailAddress: "bcarter@gmail.com",
          status: "Active"
        },
        {
          id: 5,
          firstName: "Katie",
          lastName: "Jackson",
          username: "kjackson",
          emailAddress: "kjackson@yahoo.com",
          status: "Active"
        },
        {
          id: 6,
          firstName: "Mark",
          lastName: "Smith",
          username: "msmith",
          emailAddress: "msmith@foo.com",
          status: "Disabled"
        }
      ],
      showForm: 0,
      selectedUserIDs: [],
      counter: 1
    };
  },
  methods: {
    getNextUserId() {
      return this.nextUserId++;
    },
    clearForm() {
     return this.newUser = {
        id: this.nextUserId,
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "Active"
      }
    },
    // **Step 1: function works fine, but for each user that gets added, their id = "undefined"... (cypress)
    saveUser() {
      this.users.push(this.newUser);
      this.getNextUserId()
      this.clearForm()
    },
    flipStatus(event) {
      let filteredUser = this.users.filter((user) => {return user.id === event.target.id })
      if (filteredUser.status === 'Active') {
        filteredUser.status === 'Disabled';
        
      } else {
        filteredUser.status === 'Active'
      }
    },
    clearCheckBox() {
      let checkBoxes = document.querySelectorAll('input[type=checkbox]');
      checkBoxes.forEach((checkbox) => {
        checkbox.checked = false;
      });

    },
    enableSelectedUsers() {
      this.selectedUserIDs.forEach((userID) => {
        this.users.forEach((user) => {
          if (user.id === userID) {
            user.status === "Active"
          }
        });
        this.clearCheckBox();
      });
    },
    disableSelectedUsers() {
      this.selectedUserIDs.forEach((userID) => {
        this.users.forEach((user) => {
          if (user.id === userID) {
            user.status === "Disabled"
          }
        });
        this.clearCheckBox();
      });
    },
    deleteSelectedUsers() {
      this.selectedUserIDs.forEach((userID) => {
        this.users.forEach((user) => {
          if (user.id === userID) {

           const updatedUsersArray = this.users.splice(this.users.indexOf(userID), 1);
           this.users = updatedUsersArray;

           //My more complicated method before I found out about splice...

            // let usersArrayOne = [];
            // let usersArrayTwo = [];
            // // Array one = list of users up until the user to delete...
            // for (const user of this.users[user]) {
            //   usersArrayOne.push(user)
            // }
            // // Array two = rest of the users AFTER the user to delete...
            // for (let index = this.users.indexOf(this.users[user + 1]); index < this.users.length; index++) {
            //   usersArrayTwo.push()
            // }
            
            // //Pop arrayOne, set users to equal to concatenated array....
            // usersArrayOne.pop();
            // this.users = usersArrayOne.concat(usersArrayTwo);
          }
        });
        this.clearCheckBox();
      });
    },
    addRemoveToSelectedUserIds(event) {
      if (this.selectedUserIDs.includes(event.target.id)) {
        const updatedUserIds = this.selectedUserIDs.splice(this.selectedUserIDs.indexOf(event.target.id), 1);
        this.selectedUserIDs = updatedUserIds;
      } else {
        this.selectedUserIDs.push(event.target.id);
      }
    }
  },
  computed: {
    filteredList() {
      let filteredUsers = this.users;
      if (this.filter.firstName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.firstName
            .toLowerCase()
            .includes(this.filter.firstName.toLowerCase())
        );
      }
      if (this.filter.lastName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.lastName
            .toLowerCase()
            .includes(this.filter.lastName.toLowerCase())
        );
      }
      if (this.filter.username != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.username
            .toLowerCase()
            .includes(this.filter.username.toLowerCase())
        );
      }
      if (this.filter.emailAddress != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.emailAddress
            .toLowerCase()
            .includes(this.filter.emailAddress.toLowerCase())
        );
      }
      if (this.filter.status != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.status === this.filter.status
        );
      }
      return filteredUsers;
    },
    actionButtonDisabled() {
      while (this.selectedUserIDs == []) {
        return true;
      }
      return false;
    },
    checkAllBoxes() {
      const userCheckBoxes = document.querySelectorAll(".userCheck");
      userCheckBoxes.forEach((checkBox) => {
        checkBox.checked = true;
      })
      this.users.forEach((user) => {
        this.selectedUserIDs.push(user.id);
      });
      return null;
    },
    uncheckAllBoxes() {
      let userCheckBoxes = document.querySelectorAll(".userCheck");
      userCheckBoxes.forEach((checkBox) => {
        checkBox.checked = false;
        this.selectedUserIDs.pop();
      })

      return null;
    },
    // **Step 4 - Check select all when all individual checkboxes get checked, but it doesn't work...
    checkSelectAll() {
      let selectAllCheckBox = document.getElementById("selectAll");
      selectAllCheckBox.checked = true;
      const userCheckBoxes = document.querySelectorAll(".userCheck");
      userCheckBoxes.forEach((checkBox) => {
        if(checkBox.checked == false) {
          selectAllCheckBox.checked = false;
        }
      })
      return null;
    },
  }
};
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
  margin-bottom: 20px;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}

form {
  margin: 20px;
  width: 350px;
}
.field {
  padding: 10px 0px;
}
label {
  width: 140px;
  display: inline-block;
}
button {
  margin-right: 5px;
}
.all-actions {
  margin-bottom: 40px;
}
.btn.save {
  margin: 20px;
  float: right;
}
</style>
