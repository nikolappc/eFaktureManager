import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import LoginView from '../views/Login/LoginView.vue'
import Create from '../sales/pages/Create.vue'
import Drafts from '../sales/pages/Drafts.vue'
import MyCreated from '../sales/pages/MyCreated.vue'
import ScrapSales from '../sales/pages/Scrap.vue'


import ScrapPurchase from '../purchase/pages/Scrap.vue'
import AssignedToMe from '../purchase/pages/AssignedToMe.vue'
import Booking from '../purchase/pages/Booking.vue'
import Unassigned from '../purchase/pages/Unassigned.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView,
    meta: { layout: 'MainLayout' },

  },

  // SALES PATHS
  {
    path: '/sales/create',
    name: 'create',
    component: Create,
    meta: { layout: 'SalesLayout' },

  },
  {
    path: '/sales/drafts',
    name: 'drafts',
    component: Drafts,
    meta: { layout: 'SalesLayout' },
  },
  {
    path: '/sales/my-created',
    name: 'my-created',
    component: MyCreated,
    meta: { layout: 'SalesLayout' },
  },
  {
    path: '/sales/scrap',
    name: 'scrap',
    component: ScrapSales,
    meta: { layout: 'SalesLayout' },
  }
  ,

  // PURCHASE PATHS
  {
    path: '/purchase/scrap',
    name: 'scrap-purchase',
    component: ScrapPurchase,
    meta: { layout: 'PurchaseLayout' },
  },
  {
    path: '/purchase/assigned-to-me',
    name: 'assigned-to-me',
    component: AssignedToMe,
    meta: { layout: 'PurchaseLayout' },
  },
  {
    path: '/purchase/booking',
    name: 'booking',
    component: Booking,
    meta: { layout: 'PurchaseLayout' },
  },
  {
    path: '/purchase/unassigned',
    name: 'unassigned',
    component: Unassigned,
    meta: { layout: 'PurchaseLayout' },
  },
  // OTHER
  {
    path: '/login',
    name: 'login',
    component: LoginView,
    meta: { layout: 'LoginLayout' },

  },
  {
    path: '/about',
    name: 'about',
    meta: { layout: 'MainLayout' },
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
