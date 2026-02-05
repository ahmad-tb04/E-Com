import React from "react";
import { useState } from "react";

function Greet(props) {
  const [text, setText] = useState("welcome to our website");
  return (
    <div>
      {text}
      <button onClick={() => setText("thank you for visiting")}>
        visit {props.name}
      </button>
    </div>
  );
}
export default Greet;
