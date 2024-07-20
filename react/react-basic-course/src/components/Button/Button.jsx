import classes from "./Button.module.css";

export default function Button({ children, isActive, ...props }) {
  const handleMouseEnter = () => {
    console.log("enter");
  };

  return (
    <button
      {...props}
      className={
        isActive ? `${classes.button} ${classes.active}` : classes.button
      }
      // onMouseEnter={handleMouseEnter}
      // onDoubleClick={() => {
      // console.log("dbl");
      // }}
    >
      {children}
    </button>
  );
}
