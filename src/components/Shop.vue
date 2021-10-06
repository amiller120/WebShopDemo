<template>
  <div>
    <b-container>
      <h1>Shop Page</h1>
      <b-row>
        
            <b-card-group columns>
              <div
          class="card column is-one-quarter"
          v-for="product in products"
          :key="product.id"
        >
          <b-col>
              <b-card
                img-src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fd.newsweek.com%2Fen%2Ffull%2F1119776%2Fgettyimages-159044749.jpg&f=1&nofb=1"
                img-alt="Image"
                img-top
              >
              <b-card-body style="min-height:20rem;">
                <VProducts :product="product"></VProducts>
                </b-card-body>
                <b-card-footer style="padding: 0px">
                  Last updated 3 mins ago
                </b-card-footer>
              </b-card>
              </b-col>
        </div>
            </b-card-group>
          
      </b-row>
    </b-container>
  </div>
</template>
<script>
import VProducts from "../components/Product/Product.vue";
export default {
  components: { VProducts },
  data() {
    return {
      products: [
        {
          id: 1,
          title: "Product 1",
          description:
            "Good Lord!",
          price: 50,
          ratings: 3,
          reviews: 5,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 2,
          title: "Product 2",
          description:
            "What is it, son? I'm Busy!",
          price: 35,
          ratings: 5,
          reviews: 10,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 3,
          title: "Product 3",
          description:
            "I'm seeing double... 4 Krusty's.",
          price: 110,
          ratings: 2,
          reviews: 3,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 4,
          title: "Product 4",
          description:
            "Food goes here.",
          price: 50,
          ratings: 1,
          reviews: 0,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 5,
          title: "Product 5",
          description:
            "When I grow up, I want to go to Bovine U!",
          price: 35,
          ratings: 4,
          reviews: 2,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 6,
          title: "Product 6",
          description:
            "I call the big one bitey.",
          price: 110,
          ratings: 5,
          reviews: 1,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 7,
          title: "Product 7",
          description:
            "Barney: Wait, but you didn't do anything...   Nemoy: DIdn't I?",
          price: 50,
          ratings: 5,
          reviews: 7,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 8,
          title: "Product 8",
          description:
            "I call the big one bitey. ",
          price: 35,
          ratings: 3,
          reviews: 0,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
        {
          id: 9,
          title: "Product 9",
          description:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
          price: 110,
          ratings: 4,
          reviews: 2,
          isAddedToCart: false,
          isAddedBtn: false,
          isFavourite: false,
          quantity: 1,
        },
      ],
    };
  },
};
</script>
<style>
</style>