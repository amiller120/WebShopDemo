import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import NotFound from '../components/NotFound.vue'
import Shop from '../components/Shop.vue'
import ProductDetail from '../components/Product/ProductDetail.vue'
import CreateProduct from '../components/Product/CreateProduct.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '*',
    name: 'NotFound',
    component: NotFound
  },
  {
    path: '/shop',
    name: 'Shop',
    component: Shop
  },
  {
    path: '/product-detail/:productId',
    name: 'ProductDetail',
    component: ProductDetail
  },
  {
    path: '/product/create',
    name: "create",
    component: CreateProduct
  }
]

const router = new VueRouter({
    routes
})

export default router
