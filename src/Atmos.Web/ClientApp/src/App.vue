<template>
  <div id="app">
    <AppHeader v-bind:title="title"/>
      <MixesPanel></MixesPanel>
    <div id="app-contents">
        <p v-if="loading">Loading...</p>
      <div class="container" v-if="!loading">
          
            <LandingSection></LandingSection>
            <Mixer></Mixer>
            <CreateMix></CreateMix>
      </div>
    </div>
  </div>
</template>

<script>
import AppHeader from './components/framework/AppHeader';
import Mixer from "./components/mixer/Mixer";
import LandingSection from "./components/landing/LandingSection";
import CreateMix from "./components/mixes/CreateMix";
import MixesPanel from "./components/mixes/MixesPanel";

export default {
  name: 'App',
  components: {
      MixesPanel,
    Mixer,
    AppHeader,
    LandingSection,
      CreateMix
  },
    data() {
      return {
          appTitle: "",
          loading: false
      }
    },
    created() {
      this.$store.dispatch('loadConfig');
      this.$store.dispatch('loadMixes');
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
  }
  h1, h2, h3, h4 {
    color: white;
  }
  p {
      color: #fff;
  }
  #app-contents {
    margin-top: 3em;
  }
  .container {
    max-width: 750px;
  }
</style>
