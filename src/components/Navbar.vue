<template>
    <div>
        <b-navbar toggleable="md" type="dark" variant="info">
            <b-navbar-brand to="/">DemoWebShop</b-navbar-brand>
            <b-navbar-nav>
                <b-nav-item to="/shop">Shop</b-nav-item>
            </b-navbar-nav>
            <b-navbar-nav class="ml-auto">
                <b-nav-item right><b-icon icon="cart4" style="color:white;"></b-icon></b-nav-item>
            </b-navbar-nav>
        </b-navbar>
    </div>
</template>

<script>
export default {
    name: 'Navbar'
}
</script>

<style lang="">
    
</style>
