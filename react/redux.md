# we need to have the base reducer first to be able to create the store.
import { createStore } from 'redux';

// 1. Create the reducer
const reducer = ( state, action ) => {
  return state;
}

// 2. Create the store
const store = createStore( reducer );

# Link Redux (Store) to React
Now, comes the use of react-redux. Let's import it in index.js

import { Provider } from 'react-redux';

"Provider" is a helper component that links React to Redux and allows React components to access the Redux store. It has to wrap the parent component (in this case App) to be able to be used in all child components.

ReactDOM.Render(
    <Provider store={store}>
        <App />
    </Provider>
)

# Connect React components to the Store
    using "connect" from react-redux to connect any component to the store https://react-redux.js.org/api/connect. There are two parts to connect
    ## 1. Read state from store: mapStateToProps
    ## 2. dispatch and action: mapDispatchToProps
        Let's start with reading the state

    import connect from react-redux

        connect is a higher-order component (HOC) that takes the React component and returns a new component with State in the props. 