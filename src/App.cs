.frame {
    margin: 50px 20px;
    display: flex;
    justify-content: center;
  }
  .todos_box {
    width: 250px;
    min-height: 400px;
    margin: 25px;
    box-shadow: 0px 0px 25px 1px rgba(0, 0, 0, 0.25);
    border-radius: 20px;
    padding: 20px;
  }
  /* active todos section */
  .activeTodos {
    background: #ffffff;
    justify-content: center;
  }
  form {
    display: flex;
    justify-content: space-between;
    align-items: baseline;
  }
  .activeTodosInput {
    width: 100%;
    height: 10px;
    margin-top: 20px;
    outline: none;
    background: #ffffff;
    box-shadow: inset 1px 2px 5px 1px rgba(0, 0, 0, 0.25);
    border-radius: 20px;
    border: none;
    padding: 15px;
    font-weight: 300;
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
      Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
  }
  
  /* completed todos section */
  .completedTodos {
    background: #efffff;
  }
  .checkbox {
    cursor: pointer;
    border: 1px solid rgba(0, 0, 0, 0.7);
  }
  
  /* removed todos section */
  .removedTodos {
    background: #ffefff;
  }
  
  .title {
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
      Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
    font-style: normal;
    font-weight: normal;
    font-size: 18px;
    margin-top: 30px;
    color: rgba(0, 0, 0, 0.41);
    height: 30px;
  }
  
  /* Common */
  .todos {
    margin-top: 40px;
  }
  .todo {
    width: 210px;
    min-height: 10px;
    margin-top: 15px;
    padding: 15px;
    box-shadow: 1px 2px 5px 1px rgba(0, 0, 0, 0.25);
    border-radius: 20px;
    display: flex;
    align-items: center;
    justify-content: space-between;
  }
  .todoText {
    margin: 0px 10px;
    width: 100%;
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
      Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
    color: rgba(0, 0, 0, 0.7);
    font-size: 13px;
  }
  .closeButton {
    padding-left: 10px;
    font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
    font-style: normal;
    border-left: 1px solid rgba(0, 0, 0, 0.3);
    cursor: pointer;
    display: flex;
    align-items: center;
    justify-content: center;
    color: rgba(0, 0, 0, 0.6);
  }
  .delete {
    color: red;
    font-size: 11px;
    padding: 5px;
    margin-right: -5px;
  }
  
  /* developer info section */
  .developer-info-section {
    float: right;
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
      Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
    font-size: 12px;
    margin-right: 50px;
  }
  .developer-info-section p {
    color: rgba(0, 0, 0, 0.4);
  }
  .developer-info-section p a {
    color: rgba(251, 0, 0, 0.6);
    text-decoration: none;
  }
  
  /* Responsiveness */
  @media (max-width: 880px) {
    .frame {
      flex-direction: column;
      align-items: center;
      margin: 20px;
    }
    .todos_box {
      width: 100%;
      min-height: 0px;
      margin: 0px;
      box-shadow: none;
      border-radius: 0px;
      padding: 20px;
      padding-bottom: 50px;
      border-bottom: 1px solid rgba(0, 0, 0, 0.1);
    }
    .todo {
      width: 100%;
      min-height: 40px;
      margin-top: 15px;
      padding: 0px;
    }
    .title {
      margin-top: 10px;
      color: rgba(0, 0, 0, 0.41);
      height: 10px;
    }
    .checkbox {
      margin-left: 20px;
    }
    .closeButton {
      margin-right: 20px;
    }
    .todoText {
      margin:10px 20px;
    }
  }