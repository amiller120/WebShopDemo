<template>
  <div class="product-container">
    <b-card-text style="min-height:5rem">
      {{ product.description }}
      
    </b-card-text>
    <b-list-group flush>
      <b-list-group-item><b-button pill variant="outline-secondary">Buy a Busey</b-button></b-list-group-item>
      <b-list-group-item><b-button pill variant="outline-secondary">View</b-button></b-list-group-item>
      <b-list-group-item><b-button pill variant="outline-danger">Favorite <b-icon-heart-fill></b-icon-heart-fill></b-button></b-list-group-item>
    </b-list-group>
    
    
  </div>
</template>
<script>
export default {
  props: {
    product: {
      type: Object,
      required: false,
    },
  },
};
</script>

<style>
/* .product-container{
    width: auto;
    height: auto;
    box-shadow: rgba(0, 0, 0, 0.25) 0px 0.0625em 0.0625em,
    rgba(0, 0, 0, 0.25) 0px 0.125em 0.5em,
    rgba(255, 255, 255, 0.1) 0px 0px 0px 1px inset;
} */
.inner-width {
  width: 90%;
}
</style>