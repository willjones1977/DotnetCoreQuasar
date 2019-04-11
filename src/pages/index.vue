<template>
  <q-page class="flex flex-center">
    <img alt="Quasar logo" src="~assets/quasar-logo-full.svg">

    <div class="row col-12 justify-center">
        {{ ApiIndexText }}
    </div>
    <div class="row col-12 justify-center">
        {{ APITestText }}
    </div>
  </q-page>
</template>

<style>
</style>

<script>
export default {
  name: 'PageIndex',
  data () {
    return {
      ApiIndexText: null,
      APITestText: null
    }
  },

  async created () {
    // Hit the /HelloWorld/Index endpoint
    var indexResponse = await this.$axios.get('/HelloWorld')
    this.ApiIndexText = indexResponse.data
    var testResponse = await this.$axios.get('/HelloWorld/Test')
    this.APITestText = testResponse.data
  }
}
</script>
