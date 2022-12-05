import Vue from 'vue';
import VueRouter from 'vue-router';
import MyBooks from '../views/MyBooks'
import NewBook from '../views/NewBook'
import BookDetails from '../views/BookDetails'
import Home from '../views/Home'


Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/myBooks',
    name: 'myBooks',
    component: MyBooks
  },
  {
    path: '/addBook',
    name: 'NewBook',
    component: NewBook
  },
  {
    path: '/book/:isbn',
    name: 'Book',
    component: BookDetails
  }


];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
