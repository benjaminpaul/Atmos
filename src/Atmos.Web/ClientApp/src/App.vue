<template>
  <div id="app">
    <AppHeader v-bind:title="title"/>
    <div id="app-contents">
        <p v-if="loading">Loading...</p>
      <div class="container" v-if="!loading">
            <LandingSection></LandingSection>
            <Mixer></Mixer>
      </div>
    </div>
  </div>
</template>

<script>
import AppHeader from './components/framework/AppHeader';
import Mixer from "./components/mixer/Mixer";
import LandingSection from "./components/landing/LandingSection";

export default {
  name: 'App',
  components: {
    Mixer,
    AppHeader,
    LandingSection
  },
    data() {
      return {
          appTitle: "",
          loading: false
      }
    },
    created() {
      this.$store.dispatch('loadConfig');
    },
    computed: {
      title(){
          return this.$store.state.appConfig.appTitle
      } 
    }
}
</script>

<style>
  body {
    background-color: rgb(92, 165, 229);
    color: white;
  }
  h1, h2, h3, h4 {
    color: white;
  }
  #app-contents {
    margin-top: 3em;
  }
  .container {
    max-width: 750px;
  }
</style>
