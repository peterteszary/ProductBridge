//import router and  pages component
import { createRouter, createWebHistory } from 'vue-router';
import AppHome from '../components/AppHome.vue';
import AboutView from '../views/AboutView.vue';
import HelpView from '../views/HelpView.vue';
import DatabaseView from '../views/DatabaseView.vue';


//routing settings
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'AppHome',
      component: AppHome
    },
    {
      path: '/AboutView',
      name: 'AboutView',
      component: AboutView
    },
    {
      path: '/HelpView',
      name: 'HelpView',
      component: HelpView
    },
    {
      path: '/DatabaseView',
      name: 'DatabaseView',
      component: DatabaseView
    },
    
  ]
})

export default router
