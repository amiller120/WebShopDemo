<template>
    <div>
        <b-navbar toggleable="md" type="dark" variant="info">
            <b-navbar-brand to="/">DemoWebShop</b-navbar-brand>
            <b-navbar-nav>
                <b-nav-item to="/shop">Shop</b-nav-item>
                <b-nav-item to="/product/create">Create Product</b-nav-item>
            </b-navbar-nav>
            <b-navbar-nav>
                <b-nav-item to="/product-create">New Product</b-nav-item>
            </b-navbar-nav>
            <b-navbar-nav class="ml-auto">
                <b-nav-item v-b-toggle.sidebar-right right><b-icon icon="cart4" style="color:white;"></b-icon></b-nav-item>
                <CartSidebar></CartSidebar>
            </b-navbar-nav>
        </b-navbar>
    </div>
</template>

<script>
import CartSidebar from './cart/CartSidebar.vue'

export default {
    name: "Navbar",
    components: { CartSidebar }
}
</script>

<style scoped>
   
</style>
